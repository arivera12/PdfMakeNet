using System;
using System.Collections.Generic;
using System.Text;

namespace PdfmakeCSharp.Implementations{

    class BasePdfMake : IBasePdfMake<Object>{
        public List<object> Header { get; set; }
        public List<object> Footer { get; set; }
        public List<object> Body { get; set; }
        public object Styles { get; set; }


        public void AddQRCode(IQRCode qRCode){
            Body.Add(qRCode);
        }

        public void AddQRCode(IList<IQRCode> qRCodes){
            Body.Add(qRCodes);
        }

        public void AddText(IText text){
            Body.Add(text);
        }

        public void AddText(IList<IText> texts){
            Body.Add(texts);
        }

        public void AddHeaderText(IText text) {
            Header.Add(text);
        }

        public void AddHeaderText(IList<IText> text){
            Header.Add(text);
        }

        public void AddHeaderQRCode(IList<IQRCode> qRCode){
            Header.Add(qRCode);
        }

        public void AddHeaderQRCode(IQRCode qRCode){
            Header.Add(qRCode);
        }

        public void AddFooterQRCode(IQRCode qRCode){
            Footer.Add(qRCode);
        }

        public void AddFooterText(IText text){
            Footer.Add(text);
        }

        public void AddFooterText(IList<IText> text){
            Footer.Add(text);
        }

        public void AddFooterQRCode(IList<IQRCode> qRCode){
            Footer.Add(qRCode);
        }
    }
}
