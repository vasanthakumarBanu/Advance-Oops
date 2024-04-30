using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace List
{
    public partial  class CustomList<Type>//Dynamic data type
    {
        //field creation as Count and capacity (read only properties)
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}}//list property
        public int Capacity{get{return _capacity;}}//list property
        //declare array with genric type .
        private Type [] _array;
        //indexer property
        public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index]=value;}
        }
        //constructor
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];

        }
        //Parametcric Constructor
        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];

        }
        public void Add(Type element)
        {   // if count exceeeds the capcity
            if(_count == _capacity)
            {
                GrowSize();
            }
            //adding elememt to the array
            _array[_count] = element;
            _count++;
        }
        void GrowSize()
        { //adding extrea space in array
            _capacity = _capacity *2;
            Type [] temp = new Type[_capacity];
            //Shifting the lemets to new array.
            for(int i = 0;i<_count;i++)
            {
                temp[i]=_array[i];

            }
            // giving power to new array.
            _array = temp;

        }
        // add range is to add many elements to array or list
        public void AddRange(CustomList<Type>elements)
        {
            _capacity=_count + elements._count+4;// 4 = adding extra sapce to resduce work of iteration,
            Type [] temp = new Type [_capacity];
            //creating loop to store list 
             for(int i = 0;i<_count;i++)
            {
                temp[i]=_array[i];

            }
            int k = 0; //creating new element K for new iteraion
            for(int i = _count;i<_count+elements._count;i++)// adding double the size by extra elemnts space.
            {
                //indexer = element.
                temp[i] = elements[k];
                k++;
            }
            //assigning adress of array to temp;
            _array = temp;
            //ading the count of elements to _count
            _count =_count+elements.Count;
       
        }
        // Contains. Methods
        public bool Contains(Type element)
        {
            bool temp = false;
            foreach(Type data in _array)
            {
                if(data.Equals(element))
                {
                    temp = true;
                    break;
                }
            }
            return temp;
        }
        // Contains ends

        //indexOf methods
        public int IndexOf(Type element)
        {// index is -1 because 0 also has index value
            int index = -1;
            for(int i = 0;i<_count;i++)
            {
                if(element.Equals(_array[i]))
                {//searching for index of element
                    index =i;
                    break;
                }
            }
            return index;
        }
        //insert 
        public void Insert(int position,Type element)
        {
            _capacity = _capacity+5;
            Type [] temp =new Type[_capacity];
            for(int i=0;i<=_count;i++)
            {
                if(i<position)
                {// printas usual array index
                    temp[i]=_array[i];
                }
                else if(i == position)
                {// inserting the element to array
                    temp[i] = element;
                }
                else
                {//shifitng the  array to new position
                  temp[i] = _array[i-1]; 
                }
            }
            //increasing the count
            _count++;
            _array = temp;
        }
        //indexof method ends

        //remove method
        public void RemoveAt(int position)
        {
            for(int i = 0;i<_count;i++)
            {
                if(i>=position)
                {
                    _array[i]=_array[i+1];
                }

            }
        }
        public bool Remove(Type element)

        {
            int position = IndexOf(element);
            if (position>=0)
            {
                RemoveAt(position);
                return true;
            }
            return false;

              
        }

      public void Revers()
      {
        Type [] temp = new Type [_capacity];
        int j = 0;
        for(int i = _count -1;i>=0;i--)
        {
            temp[j]=_array [i];
            j++;
        }
        _array = temp;
      } 
        

        
    }
}