//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataTest.Models.StoreRequestTest
//{
//    class teste
//    {
//        [Fact]
//        public void TestarSePropriedadeDescricaoExiste()
//        {
//            Type t = typeof(Salgado);
//            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Descricao");
//            Assert.NotNull(pI);
//        }

//        [Fact]
//        public void TestarSePropriedadeDescricaoEString()
//        {
//            Type t = typeof(Salgado);
//            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Descricao");
//            Type typeString = typeof(string);
//            Type typeProperty = pI != null ? pI.PropertyType : null;
//            Assert.Equal(typeString, typeProperty);
//        }
//        [Fact]
//        public void TestarSePropriedadeDescricaoGet()
//        {
//            Salgado s = new Salgado();
//            Type t = typeof(Salgado);
//            PropertyInfo pI = t.GetProperties().FirstOrDefault(p => p.Name == "Descricao");

//            object valueProp = null;
//            if (pI != null && pI.PropertyType == typeof(String))
//            {

//                pI.SetValue(s, "");
//                valueProp = pI.GetValue(s);
//            }

//            Assert.NotNull(valueProp);
//        }
//    }
//}
