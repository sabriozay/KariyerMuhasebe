﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhabeIT_Destop.Models
{
    public class CalisanModel
    {
        public int Id { get; set; }
        public String Ad { get; set; }
        public String Soyad { get; set; }
        public String Departman { get; set; }
        public String Yetki { get; set; }
        public String Maas { get; set; }

        public String Gsm { get; set; }

        public String TC { get; set; }

        public String Adres { get; set; }
        public CalisanModel()
        {

        }
        public CalisanModel(int mId, String mAd, String mSoyadi, String mDepartman, String mYetki, String mMaas,String mGsm,String mTC,String mAdres)
        {
            this.Id = mId;
            this.Ad = mAd;
            this.Soyad = mSoyadi;
            this.Departman = mDepartman;
            this.Yetki = mYetki;
            this.Maas = mMaas;
            this.Gsm = mGsm;
            this.TC = mTC;
            this.Adres = mAdres;
        }

    }
}
