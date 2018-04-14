using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using ThirdPartyDll;

namespace AssemblyEnumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the current application domain for the current thread.
            AppDomain currentDomain = AppDomain.CurrentDomain;

            // Create a dynamic assembly in the current application domain,
            // and allow it to be executed and saved to disk.
            AssemblyName aName = new AssemblyName("TempAssembly");
            AssemblyBuilder ab = currentDomain.DefineDynamicAssembly(aName, AssemblyBuilderAccess.RunAndSave);

            // Define a dynamic module in "TempAssembly" assembly. For a single-
            // module assembly, the module has the same name as the assembly.
            ModuleBuilder mb = ab.DefineDynamicModule(aName.Name, aName.Name + ".dll");

            // Define a public enumeration with the name "Elevation" and an 
            // underlying type of Integer.
            EnumBuilder eb = mb.DefineEnum("Elevation", TypeAttributes.Public, typeof(int));

            // Define two members, "High" and "Low".
            eb.DefineLiteral("Low", 0);
            eb.DefineLiteral("High", 1);

            // Create the type and save the assembly.
            Type finished = eb.CreateType();
            ab.Save(aName.Name + ".dll");

            Assembly ass = Assembly.LoadFrom("TempAssembly.dll");
            Type typ = ass.GetType("Elevation");
            string[] values = typ.GetEnumNames();

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

            FieldInfo[] fields = typ.GetFields();

            foreach (var field in fields)
            {
                if (field.Name.Equals("value__")) continue;

                Console.WriteLine("{0,-9} {1}", field.Name + ":",
                                                field.GetRawConstantValue());
            }

            try
            {
                Assembly ass1 = Assembly.LoadFrom("CL_Pets.dll");
                Type[] typs = ass1.GetTypes();
                foreach (Type t in typs)
                {
                    Console.WriteLine(t);
                }
                Type typ1 = ass1.GetType("ThirdPartyDll.Pets");
                string[] values1 = typ1.GetEnumNames();

                foreach (var value in values1)
                {
                    Console.WriteLine(value);
                }

                FieldInfo[] fields1 = typ1.GetFields();

                foreach (var field in fields1)
                {
                    if (field.Name.Equals("value__")) continue;

                    Console.WriteLine("{0,-9} {1}", field.Name + ":",
                                                    field.GetRawConstantValue());
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }
    }
}
