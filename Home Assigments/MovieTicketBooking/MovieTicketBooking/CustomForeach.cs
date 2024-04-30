using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public partial class CustomList<Type>:IEnumerable,IEnumerator
    {
        int position;
        public IEnumerator GetEnumerator()
        //Starting from Length-1 (last index)
        { position = _count-1;
            return(IEnumerator)this;
        }
        public bool MoveNext()
        {
            //changeing the conditions to reverse oder
            if(position>-1)
            {
                --position;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            position =_count-1;
        }
        public object Current{get{return _array[position];}}
    }
}