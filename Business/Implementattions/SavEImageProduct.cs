using System;
using System.Collections.Generic;
using System.Linq;
using LojaVirtual.Data.Converter;
using LojaVirtual.Data.VO;
using LojaVirtual.Model;
using System.IO;

namespace LojaVirtual.Business.Implementations
{
    public class SaveImageProduct
    {
        private Product Product {get;set;}
        
        //TODO REFATORAR
        public SaveImageProduct(Product product){
            this.Product = product;
        }

        public void SaveFile( ) {
           SaveFilePrincipal();
        }

        public void SaveFilePrincipal(){
            byte[] bytes = Product.Image;
            string fileId = Product.Id.ToString();

            File.WriteAllBytes(@"/home/vitor777/Desktop/loja_virtual/produtos_imagem/" + fileId + ".png", bytes);

        }

        public void SaveFile02(){
            byte[] bytes= Product.Image_2;
            string fileId = Product.Id.ToString() + "_2";

            File.WriteAllBytes(@"/home/vitor777/Desktop/loja_virtual/produtos_imagem/" + fileId + ".png", bytes);

        }

        public void SaveFile03(){
            byte[] bytes = Product.Image_3;
            string fileId = Product.Id.ToString() + "_3";

            File.WriteAllBytes(@"/home/vitor777/Desktop/loja_virtual/produtos_imagem/" + fileId + ".png", bytes);
        }

        public void SaveFile04(){
            byte[] bytes =  Product.Image_4;
            string fileId = Product.Id.ToString() + "_4";

            File.WriteAllBytes(@"/home/vitor777/Desktop/loja_virtual/produtos_imagem/" + fileId + ".png", bytes);

        }

        public void SaveFile05(){
            byte[] bytes = Product.Image_5;
            string fileId = Product.Id.ToString() + "_5";

            File.WriteAllBytes(@"/home/vitor777/Desktop/loja_virtual/produtos_imagem/" + fileId + ".png", bytes);
        }

        public void Save(){
            SaveFilePrincipal();
            SaveFile02();
            SaveFile03();
            SaveFile04();
            SaveFile05();
        }

    }
}
