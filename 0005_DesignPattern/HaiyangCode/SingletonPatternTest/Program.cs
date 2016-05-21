using System;
using System.Runtime.InteropServices;

namespace SingletonPatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get first singleton instance
            Console.WriteLine("Singleton instance is : Name={0}, ID={1}", Singleton.Instance.Name, Singleton.Instance.ID);

            GCHandle objHandle1 = GCHandle.Alloc(Singleton.Instance, GCHandleType.WeakTrackResurrection);
            string address1 = GCHandle.ToIntPtr(objHandle1).ToString();
            Console.WriteLine("Singleton instance Address={0} ", address1);


            // Get second singleton instance
            Console.WriteLine("Singleton instance is : Name={0}, ID={1}", Singleton.Instance.Name, Singleton.Instance.ID);

            GCHandle objHandle2 = GCHandle.Alloc(Singleton.Instance, GCHandleType.WeakTrackResurrection);
            string address2 = GCHandle.ToIntPtr(objHandle2).ToString();

            // Memory address in .Net aren't static. Objects get moved around all the time by the memory manager. So this time the address of the  
            // singleton instance moved.
            Console.WriteLine("Singleton instance Address={0} ", address2);

            Console.ReadKey();
        }
    }
}
