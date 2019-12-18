using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Lib
{
    public class ContentLib
    {
        OnlineShopDbContext db = null;
        public ContentLib()
        {
            db = new OnlineShopDbContext();
        }

        public Content GetByID(long id)
        {
            return db.Contents.Find(id);
        }
    }
}
