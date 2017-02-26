﻿// <copyright file="ShippingAddressPage.Map.cs" company="Automate The Planet Ltd.">
// Copyright 2017 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>http://automatetheplanet.com/</site>
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WebDriverCsharpSeven.LocalFunctions
{
    public partial class ShippingAddressPage
    {
        // Prior C# 7.0
        ////public void AssertPurchaseOrders(List<PurchaseOrder> purchaseOrders)
        ////{
        ////    for (int i = 0; i < purchaseOrders.Count; i++)
        ////    {
        ////        Assert.AreEqual(GetFormattedPurchaseOrder(purchaseOrders[i]), PurchaseOrderRows[i].Text);
        ////    }
        ////}

        ////private string GetFormattedPurchaseOrder(PurchaseOrder purchaseOrder)
        ////{
        ////    return $"Your product: {purchaseOrder.ProductName} costs {purchaseOrder.Price}";
        ////}

        // C# 7.0
        public void AssertPurchaseOrders(List<PurchaseOrder> purchaseOrders)
        {
            string GetFormattedPurchaseOrder(PurchaseOrder purchaseOrder) => $"Your product: {purchaseOrder.ProductName} costs {purchaseOrder.Price}";
            for (int i = 0; i < purchaseOrders.Count; i++)
            {
                Assert.AreEqual(GetFormattedPurchaseOrder(purchaseOrders[i]), PurchaseOrderRows[i].Text);
            }
        }
    }
}
