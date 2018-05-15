using CapstoneWIE.DataLayer.Interfaces;
using CapstoneWIE.DataLayer.Models;
using CapstoneWIE.DataLayer.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneWIE.DataLayer.Repositories
{
    public class MockBlogPostRepository : IBlogPostRepository
    {
        
        private List<BlogPost> _mockBlogPosts;

        public MockBlogPostRepository()
        {

            _mockBlogPosts = new List<BlogPost>()
            {
                new BlogPost()
                {
                    Id=2,
                    Content="<p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem.</p>" +
                            "<p>Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus.</p>" +
                            "<p>Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. " + 
                            "Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. N</p>",
                    PostDate=new DateTime(2016, 1, 1),
                    ApplicationUserId="6a8326da-0056-4ec9-a2ae-b22875a442ed",
                    BlogState=BlogState.Approved,
                    Tags=new List<Tag>
                    {
                        new Tag()
                        {
                            Id=1,
                            Name="test"
                        },
                        new Tag()
                        {
                            Id=2,
                            Name="willstest"
                        }

                    }
                },
            };
        }

        public IQueryable<BlogPost> BlogPosts => throw new NotImplementedException();

        public int Add(BlogPost post)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BlogPost> Get()
        {
            return _mockBlogPosts;
        }

        public IEnumerable<BlogPost> GetApprovedPostsByDate()
        {
            return Get().Where(b => b.BlogState == BlogState.Approved).OrderByDescending(b => b.PostDate);
        }

        public BlogPost GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BlogPost> GetDraftAndPendingByUserOrderByDate(string id)
        {
            return Get().Where( b => b.ApplicationUserId == id && (b.BlogState == BlogState.Draft || b.BlogState == BlogState.Pending)).OrderByDescending(b => b.PostDate);
        }

        public IEnumerable<BlogPost> GetPendingPostsByDate()
        {
            return Get().Where(b => b.BlogState == BlogState.Pending).OrderByDescending(b => b.PostDate);
        }

        public void Update(BlogPost blogInDb)
        {
            throw new NotImplementedException();
        }
    }
}
