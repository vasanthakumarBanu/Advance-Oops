using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
   public partial  class CustomList<Type>
    {
    
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}}
        public int Capacity{get{return _capacity;}}
        private Type [] _array;
        public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index]=value;}
        }
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];

        }
        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];

        }
        public void Add(Type element)
        {  
            if(_count == _capacity)
            {
                GrowSize();
            }
            
            _array[_count] = element;
            _count++;
        }
        void GrowSize()
        { 
            _capacity = _capacity*2;
            Type [] temp = new Type[_capacity];
          
            for(int i = 0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array = temp;
        }
        public void AddRange(CustomList<Type>elements)
        {
            _capacity=_count + elements._count+4;
            Type [] temp = new Type [_capacity];
           
             for(int i = 0;i<_count;i++)
            {                temp[i]=_array[i];
            }
            int k = 0; 
            for(int i = _count;i<_count+elements._count;i++)
            {
               
                temp[i] = elements[k];
                k++;
            }
            _array = temp;
            _count =_count+elements.Count;
       
        }  
    }
}