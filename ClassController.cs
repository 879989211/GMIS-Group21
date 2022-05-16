using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMIS
{
    class ClassControler
    {
        private List<class> m;
        public List<class> Classes{ get { return m; } set { } }

        private ObservableCollection<class> viewablem;
        public ObservableCollection<class> VisibleClasses { get { return viewablem; } set { } }

        public ObservableCollection<class> GetViewableList()
        {
            return VisibleClasses;
        }



    }
}
