﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Org.Mentalis.Proxy;
using System.Collections;

namespace ProxyMVCv1.Models
{
    public class ProxyModel
    {
        public static bool Flag = false;
        public Proxy proxy;
        public ProxyModel(){
            proxy = new Proxy("C:\\Users\\CO\\Desktop\\" + "config.xml");
        }
        public void StartProxy(string classtype, string host, string port)
        {
            var construct = "host:" + host+ ";int:" + port;
            proxy.Start(classtype, construct);
        }

        public Hashtable ListProxy()
        {
            Hashtable hashtable = new Hashtable();
            if (!Flag)
            {
                proxy.LoadProxy();
                Flag = true;
            }
            hashtable = proxy.ShowListeners();
            return hashtable;
        }
 
        public void DeleteProxy(string id){
            proxy.DelListener(id);
        }
    }
}