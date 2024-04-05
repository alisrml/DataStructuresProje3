using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresProje3
{
    internal class HEAPNODE
    {
        private UM_ALANI data;
        public HEAPNODE(UM_ALANI data)
        {
            this.data = data;
        }

        public UM_ALANI getData()
        {
            return this.data;
        }

        public void setData(UM_ALANI data)
        {
            this.data = (UM_ALANI)data;
        }
    }
}
