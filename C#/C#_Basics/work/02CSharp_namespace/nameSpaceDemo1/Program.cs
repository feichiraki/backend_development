// 命名空间的三种引用方式
// 1.完全限定名称：从父级到子孙级，一条线从上到下进行访问。类似于绝对路径找一个文件的位置。
// 2.非限定名称(用到using)：using将所有的层级在文件头部引入，代码块中直接访问对应的成员
// 3.部分限定名称(用到using)：在某些情况下，我们需要访问同级命名空间中的内容。


#region 完全限定名称
// using System;

// namespace nameSpaceDemo1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             MyNameSpace.Student.Show();
//         }
//     }
// }


// namespace MyNameSpace
// {
//     class Student
//     {
//         public static void Show()
//         {
//             Console.WriteLine("这里是学生列表");
//         }
//     }
// }

#endregion

#region 非限定命名
// using System;
// using MyNameSpace.Codes;

// namespace nameSpaceDemo1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Student.Show();
//         }
//     }
// }


// namespace MyNameSpace
// {
//     namespace Codes
//     {
//         class Student
//         {
//             public static void Show()
//             {
//                 Console.WriteLine("这里是学生信息");
//             }
//         }
//     }
// }
#endregion

#region 部分限定命名
using System;

namespace Outer
{
    namespace nameSpaceDemo1
    {
        class Program
        {
            static void Main(string[] args)
            {
                // 通过部分限定名称调用Show方法
                MyNameSpace.Student.Show();
            }
        }
    }

    namespace MyNameSpace
    {
        class Student
        {
            public static void Show()
            {
                Console.WriteLine("这里是学生信息");
            }
        }
    }
}
#endregion






