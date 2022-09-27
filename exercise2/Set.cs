using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    public class Set
    {
        private bool[] arr;
        public Set()
        {
            arr = new bool[1001];
        }
        public Set(params int[] values) : this() 
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (ValidInput(values[i]))
                    arr[values[i]] = true; //this.insert(value);
            }
        }
        public void Union(Set other) //when at least one value is true
        {
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = arr[i] || other.arr[i]; //if  this.arr[i] && other[i] = true; so push to the array
                                                      //if  this.arr[i] && other[i] = false; so dont push to the array
                                                      //if  this.arr[i] || other[i] = true; so dont push to the array
            }
        }
        public void Intersect(Set other)//when both values are true
        {
            for (int i = 0; i < arr.Length; i++)
            {
                this.arr[i] = arr[i] && other.arr[i];//to push the indexs to the array
            }
        }
        public bool Subset(Set other) //check if 'otherSet' is part of the 'thisSet' 
        {
            for (int i = 0; i < other.arr.Length; i++)
            {
                if (!arr[i] && other.arr[i]) //if (arr[i] == false && other.arr[i] == true)
                    return false;
            }
            return true;
        }
        public bool IsMemeber(int number) // check if the number that we got is 'on' in the array. 
        {
            if (!ValidInput(number))
                return false;
            if (this.arr[number] == true)
                return true;
            return false;
        }
        public void Insert(int number)// add a number to the array
        {
            if (ValidInput(number))
                this.arr[number] = true;
        }
        public void Delete(int number)
        {
            if (ValidInput(number))
                this.arr[number] = false;
        }
        public override string ToString()
        {
            string text = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i])
                {
                    text += $"{i} ";
                }
            }
            return text;
        }
        private bool ValidInput(int number)// check if the number is in range 
        {
            if (number > 1000 || number < 0)
                return false;
            return true;
        }
        public override bool Equals(object obj)
        {
            Set otherSet = (Set)obj;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != otherSet.arr[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}