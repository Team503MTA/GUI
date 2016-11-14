using System;
using System.Reflection;

namespace DatabaseDAL.Memory
{
    public class GetEntitiyByField
    {
        public static void GetData(string entityName, string field,dynamic value)
        {
            //get class
            Type myType = Type.GetType(entityName);
            object instance = Activator.CreateInstance(myType);

            //get field
            var dicType = "Dic" + entityName;
            var dic = typeof (Memory).GetFields(BindingFlags.Static | BindingFlags.Public);
            for (int i = 0; i < dic.Length; i++)
            {
                if (dic[i].Name == dicType)
                {
                    var dicEntity = dic[i].GetValue(null);
                    if (dicEntity != null)
                    {
                        
                    }
                }
            }
        }
    }
}
