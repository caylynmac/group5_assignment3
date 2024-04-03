using System;
using Assignment3.Utility;
using Assignment3.ProblemDomain;

namespace Assignment3
{
    public interface ILinkedListADT
    {
        bool IsEmpty();
        void Clear();
        void AddLast(User value);
        void AddFirst(User value);
        void Add(User value, int index);
        void Replace(User value, int index);
        int Count();
        void RemoveFirst();
        void RemoveLast();
        void Remove(int index);
        User GetValue(int index);
        int IndexOf(User value);
        bool Contains(User value);

       
        void Reverse();
        void Sort();
        User[] CopyToArray();
        void Join(ILinkedListADT otherList);
        (ILinkedListADT, ILinkedListADT) Divide(int index);
    }
}
