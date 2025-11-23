using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma.Dependency_inversion_principle
{
    public class Bildirim
    {
        private IList<IMesaj> _mesajlar;

        public Bildirim(IList<IMesaj> mesajlar)
        {
            _mesajlar = mesajlar;
        }
        public void BildirimGonder()
        {
            foreach (var mesaj in _mesajlar)
            {
                mesaj.MesajGonder();
            }
        }
    }
}
