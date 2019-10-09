using System.Collections.Generic;
using System.Reflection;

namespace PdfMakeNet
{
    public static class PdfMakeBaseExtensions
    {
        /// <summary>
        /// Extension method to help you build tables more faster an easier without the hassle of loops and structure
        /// </summary>
        /// <param name="Columns"></param>
        /// <param name="Rows"></param>
        /// <returns></returns>
        public static List<object> AddTableBodyStructure(this PdfMakeBase pdfMakeBase, List<string> Columns, List<object> Rows)
        {
            var body = new List<object>
            {
                Columns
            };
            foreach (var items in Rows)
            {
                var values = new List<object>();
                var type = items.GetType();
                if (type.GetGenericArguments()[0].IsSimpleType() && !type.IsAnonymousType())
                {
                    foreach (var item in (dynamic)items)
                    {
                        values.Add(item);
                    }
                }
                else
                {
                    foreach (PropertyInfo prop in items.GetType().GetProperties())
                    {
                        values.Add(items.GetType().GetProperty(prop.Name).GetValue(items));
                    }
                }
                body.Add(values);
            }
            return body;
        }
    }
}
