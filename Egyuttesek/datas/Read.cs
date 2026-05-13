using Egyuttesek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egyuttesek.Datas
{
    public class Read
    {
        public List<Albumok> ReadAlbumok()
        {

            using (var context = new librarydbContext())
            {
                var users = context.Albumok.ToList();
                return users;
            }
        }
        public int GetTagokSzama(string egyuttesNeve)
        {
            using (var context = new librarydbContext())
            {
                return context.Zeneszek.Count(z => z.egyuttes == egyuttesNeve);
            }
        }
    }

}
