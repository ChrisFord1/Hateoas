using Ben.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ben.Controllers
{
    public abstract class BlogControllerBase : ApiController
    {
        protected static readonly List<Post> posts = new List<Post>();

        public BlogControllerBase()
        {

        }
    }
}
