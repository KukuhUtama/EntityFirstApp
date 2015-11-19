using EntityFirstApp.Base;
using EntityFirstApp.Context;
using EntityFirstApp.IContext;
using EntityFirstApp.Model;
using EntityFirstApp.Repository_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Repository
{
    public class VideoRepository : RepositoryBase<Video,AppContext>, IVideoRepository
    {
        private AppContext _context;


        public VideoRepository(IDatabaseFactory<AppContext> databaseFactory)
            : base(databaseFactory)
        {
            this._context = new AppContext();
        }
    }
}
