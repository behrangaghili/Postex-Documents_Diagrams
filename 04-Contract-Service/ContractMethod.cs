interface User{

public int saveContract(ContractItems item, out string _error)
        {
            try
            {
                _error = "";
                if (item.ContractId != 0)
                {
                    DeActiveCurrentContract(item.ContractId);
                }
                Tbl_Contract cnt = new Tbl_Contract()
                {
                    CustomerId = item.CustomerId,
                    DeActtivadate = null,
                    EndDate = DateTime.Now.AddDays(1825),
                    IsActive = true,
                    RegisterContract = _workContext.CurrentCustomer.Id,
                    RegisterDate = DateTime.Now,
                    StartDate = DateTime.Now
                };
                _TblContract.Insert(cnt);
                if (cnt.Id > 0)
                {
                    if (item.RegistereContrctor > 0)// ثبت نام
                    {
                        Tbl_ContractItems cnt_Item = new Tbl_ContractItems();
                        cnt_Item.ContractItemsTypeId = 1;
                        cnt_Item.ContractId_fk = cnt.Id;
                        cnt_Item.AddDate = DateTime.Now;
                        cnt_Item.ContractorCustomerId = item.RegistereContrctor;
                        cnt_Item.DeActiveCustomer = null;
                        cnt_Item.IsActive = true;
                        _TblContractItems.Insert(cnt_Item);
                        if (cnt_Item.Id > 0)
                        {
                            Tbl_ContractItemDetail _contractItemDetail = new Tbl_ContractItemDetail()
                            {
                                DeActiveDate = null,
                                DeActiveCustomer = null,
                                ContractItemPercent = null,
                                ContractItemNumber = null,
                                ContractItemId_fk = cnt_Item.Id,
                                ContractItemDetailesCost = item.RegistereContrctorCost,
                                ContractItemDetailesPrice = item.RegistereContrctorPrice,
                                ContractItemDetailesName = null
                            };
                            _TblContractItemDetail.Insert(_contractItemDetail);
                        }
                    }
                    if (item.CollectorContrctor > 0)// جمع آوری
                    {
                        Tbl_ContractItems cnt_Item2 = new Tbl_ContractItems();
                        cnt_Item2.ContractItemsTypeId = 2;
                        cnt_Item2.ContractId_fk = cnt.Id;
                        cnt_Item2.AddDate = DateTime.Now;
                        cnt_Item2.ContractorCustomerId = item.CollectorContrctor;
                        cnt_Item2.DeActiveCustomer = null;
                        cnt_Item2.IsActive = true;
                        _TblContractItems.Insert(cnt_Item2);
                        if (cnt_Item2.Id > 0)
                        {
                            Tbl_ContractItemDetail _contractItemDetail2 = new Tbl_ContractItemDetail()
                            {
                                DeActiveDate = null,
                                DeActiveCustomer = null,
                                ContractItemPercent = null,
                                ContractItemNumber = null,
                                ContractItemId_fk = cnt_Item2.Id,
                                ContractItemDetailesCost = item.CollectorContrctorCost,
                                ContractItemDetailesPrice = item.CollectorContrctorPrice,
                                ContractItemDetailesName = null
                            };
                            _TblContractItemDetail.Insert(_contractItemDetail2);
                        }
                    }
                    if (item.PackingContractor > 0)// بسته بندی
                    {
                        Tbl_ContractItems cnt_Item3 = new Tbl_ContractItems();
                        cnt_Item3.ContractItemsTypeId = 3;
                        cnt_Item3.ContractId_fk = cnt.Id;
                        cnt_Item3.AddDate = DateTime.Now;
                        cnt_Item3.ContractorCustomerId = item.PackingContractor;
                        cnt_Item3.DeActiveCustomer = null;
                        cnt_Item3.IsActive = true;
                        _TblContractItems.Insert(cnt_Item3);
                        if (cnt_Item3.Id > 0 && item.PackingContractorItems != null)
                        {
                            foreach (var P_item in item.PackingContractorItems)
                            {
                                Tbl_ContractItemDetail _contractItemDetail3 = new Tbl_ContractItemDetail()
                                {
                                    DeActiveDate = null,
                                    DeActiveCustomer = null,
                                    ContractItemPercent = null,
                                    ContractItemNumber = null,
                                    ContractItemId_fk = cnt_Item3.Id,
                                    ContractItemDetailesCost = P_item.CartoonItemsCost,
                                    ContractItemDetailesPrice = P_item.CartoonItemsPrice,
                                    ContractItemDetailesName = P_item.CartoonItemsName
                                };
                                _TblContractItemDetail.Insert(_contractItemDetail3);
                            }
                        }
                    }
                    if (item.PriningContrctor > 0)// چاپ و الصاق فاکتور
                    {
                        Tbl_ContractItems cnt_Item4 = new Tbl_ContractItems();
                        cnt_Item4.ContractItemsTypeId = 4;
                        cnt_Item4.ContractId_fk = cnt.Id;
                        cnt_Item4.AddDate = DateTime.Now;
                        cnt_Item4.ContractorCustomerId = item.PriningContrctor;
                        cnt_Item4.DeActiveCustomer = null;
                        cnt_Item4.IsActive = true;
                        _TblContractItems.Insert(cnt_Item4);
                        if (cnt_Item4.Id > 0)
                        {
                            Tbl_ContractItemDetail _contractItemDetail4 = new Tbl_ContractItemDetail()
                            {
                                DeActiveDate = null,
                                DeActiveCustomer = null,
                                ContractItemPercent = null,
                                ContractItemNumber = null,
                                ContractItemId_fk = cnt_Item4.Id,
                                ContractItemDetailesCost = item.PriningContrctorCost,
                                ContractItemDetailesPrice = item.PriningContrctorPrice,
                                ContractItemDetailesName = null
                            };
                            _TblContractItemDetail.Insert(_contractItemDetail4);
                        }
                    }
                    if (item.LeasingPercent > 0)// میزان درصد خدمات لیزینگ
                    {
                        Tbl_ContractItems cnt_Item5 = new Tbl_ContractItems();
                        cnt_Item5.ContractItemsTypeId = 5;
                        cnt_Item5.ContractId_fk = cnt.Id;
                        cnt_Item5.AddDate = DateTime.Now;
                        cnt_Item5.ContractorCustomerId = null;
                        cnt_Item5.DeActiveCustomer = null;
                        cnt_Item5.IsActive = true;
                        _TblContractItems.Insert(cnt_Item5);
                        if (cnt_Item5.Id > 0)
                        {
                            Tbl_ContractItemDetail _contractItemDetail5 = new Tbl_ContractItemDetail()
                            {
                                DeActiveDate = null,
                                DeActiveCustomer = null,
                                ContractItemPercent = item.LeasingPercent,
                                ContractItemNumber = null,
                                ContractItemId_fk = cnt_Item5.Id,
                                ContractItemDetailesCost = null,
                                ContractItemDetailesPrice = null,
                                ContractItemDetailesName = null
                            };
                            _TblContractItemDetail.Insert(_contractItemDetail5);
                        }
                    }
                    if (item.ReturnRoofValue > 0)//حداکثر سقف مجاز برگشتی
                    {
                        Tbl_ContractItems cnt_Item6 = new Tbl_ContractItems();
                        cnt_Item6.ContractItemsTypeId = 6;
                        cnt_Item6.ContractId_fk = cnt.Id;
                        cnt_Item6.AddDate = DateTime.Now;
                        cnt_Item6.ContractorCustomerId = null;
                        cnt_Item6.DeActiveCustomer = null;
                        cnt_Item6.IsActive = true;
                        _TblContractItems.Insert(cnt_Item6);
                        if (cnt_Item6.Id > 0)
                        {
                            Tbl_ContractItemDetail _contractItemDetail6 = new Tbl_ContractItemDetail()
                            {
                                DeActiveDate = null,
                                DeActiveCustomer = null,
                                ContractItemPercent = null,
                                ContractItemNumber = item.ReturnRoofValue,
                                ContractItemId_fk = cnt_Item6.Id,
                                ContractItemDetailesCost = null,
                                ContractItemDetailesPrice = null,
                                ContractItemDetailesName = null
                            };
                            _TblContractItemDetail.Insert(_contractItemDetail6);
                        }
                    }
                    if (item.DailyCrediteRoofValue > 0)//سقف اعتبار روزانه
                    {
                        Tbl_ContractItems cnt_Item7 = new Tbl_ContractItems();
                        cnt_Item7.ContractItemsTypeId = 7;
                        cnt_Item7.ContractId_fk = cnt.Id;
                        cnt_Item7.AddDate = DateTime.Now;
                        cnt_Item7.ContractorCustomerId = null;
                        cnt_Item7.DeActiveCustomer = null;
                        cnt_Item7.IsActive = true;
                        _TblContractItems.Insert(cnt_Item7);
                        if (cnt_Item7.Id > 0)
                        {
                            Tbl_ContractItemDetail _contractItemDetail7 = new Tbl_ContractItemDetail()
                            {
                                DeActiveDate = null,
                                DeActiveCustomer = null,
                                ContractItemPercent = null,
                                ContractItemNumber = item.DailyCrediteRoofValue,
                                ContractItemId_fk = cnt_Item7.Id,
                                ContractItemDetailesCost = null,
                                ContractItemDetailesPrice = null,
                                ContractItemDetailesName = null
                            };
                            _TblContractItemDetail.Insert(_contractItemDetail7);
                        }
                    }
                    if (item.ShippingAcceptancePercentageValue > 0)//درصد قبول مرسوله
                    {
                        Tbl_ContractItems cnt_Item8 = new Tbl_ContractItems();
                        cnt_Item8.ContractItemsTypeId = 8;
                        cnt_Item8.ContractId_fk = cnt.Id;
                        cnt_Item8.AddDate = DateTime.Now;
                        cnt_Item8.ContractorCustomerId = null;
                        cnt_Item8.DeActiveCustomer = null;
                        cnt_Item8.IsActive = true;
                        _TblContractItems.Insert(cnt_Item8);
                        if (cnt_Item8.Id > 0)
                        {
                            Tbl_ContractItemDetail _contractItemDetail8 = new Tbl_ContractItemDetail()
                            {
                                DeActiveDate = null,
                                DeActiveCustomer = null,
                                ContractItemPercent = item.ShippingAcceptancePercentageValue,
                                ContractItemNumber = null,
                                ContractItemId_fk = cnt_Item8.Id,
                                ContractItemDetailesCost = null,
                                ContractItemDetailesPrice = null,
                                ContractItemDetailesName = null
                            };
                            _TblContractItemDetail.Insert(_contractItemDetail8);
                        }
                    }
                    if (item.MarketingCommissionValue > 0)//کمیسیون بازاریاب خدمات پستی
                    {
                        Tbl_ContractItems cnt_Item9 = new Tbl_ContractItems();
                        cnt_Item9.ContractItemsTypeId = 9;
                        cnt_Item9.ContractId_fk = cnt.Id;
                        cnt_Item9.AddDate = DateTime.Now;
                        cnt_Item9.ContractorCustomerId = null;
                        cnt_Item9.DeActiveCustomer = null;
                        cnt_Item9.IsActive = true;
                        _TblContractItems.Insert(cnt_Item9);
                        if (cnt_Item9.Id > 0)
                        {
                            Tbl_ContractItemDetail _contractItemDetail9 = new Tbl_ContractItemDetail()
                            {
                                DeActiveDate = null,
                                DeActiveCustomer = null,
                                ContractItemPercent = item.MarketingCommissionValue,
                                ContractItemNumber = null,
                                ContractItemId_fk = cnt_Item9.Id,
                                ContractItemDetailesCost = null,
                                ContractItemDetailesPrice = null,
                                ContractItemDetailesName = null
                            };
                            _TblContractItemDetail.Insert(_contractItemDetail9);
                        }
                    }
                    if (item.MarketingCommissionLeasing > 0)//کمیسیون بازاریاب خدمات لیزینگ
                    {
                        Tbl_ContractItems cnt_Item10 = new Tbl_ContractItems();
                        cnt_Item10.ContractItemsTypeId = 10;
                        cnt_Item10.ContractId_fk = cnt.Id;
                        cnt_Item10.AddDate = DateTime.Now;
                        cnt_Item10.ContractorCustomerId = null;
                        cnt_Item10.DeActiveCustomer = null;
                        cnt_Item10.IsActive = true;
                        _TblContractItems.Insert(cnt_Item10);
                        if (cnt_Item10.Id > 0)
                        {
                            Tbl_ContractItemDetail _contractItemDetail10 = new Tbl_ContractItemDetail()
                            {
                                DeActiveDate = null,
                                DeActiveCustomer = null,
                                ContractItemPercent = item.MarketingCommissionLeasing,
                                ContractItemNumber = null,
                                ContractItemId_fk = cnt_Item10.Id,
                                ContractItemDetailesCost = null,
                                ContractItemDetailesPrice = null,
                                ContractItemDetailesName = null
                            };
                            _TblContractItemDetail.Insert(_contractItemDetail10);
                        }
                    }
                    if (item.AffiliateContrctor > 0)//بازاریاب
                    {
                        Tbl_ContractItems cnt_Item11 = new Tbl_ContractItems();
                        cnt_Item11.ContractItemsTypeId = 11;
                        cnt_Item11.ContractId_fk = cnt.Id;
                        cnt_Item11.AddDate = DateTime.Now;
                        cnt_Item11.ContractorCustomerId = item.AffiliateContrctor;
                        cnt_Item11.DeActiveCustomer = null;
                        cnt_Item11.IsActive = true;
                        _TblContractItems.Insert(cnt_Item11);
                    }
                    if (item.CODPercent > 0)//درصد تراکنش COD
                    {
                        Tbl_ContractItems cnt_Item12 = new Tbl_ContractItems();
                        cnt_Item12.ContractItemsTypeId = 12;
                        cnt_Item12.ContractId_fk = cnt.Id;
                        cnt_Item12.AddDate = DateTime.Now;
                        cnt_Item12.ContractorCustomerId = null;
                        cnt_Item12.DeActiveCustomer = null;
                        cnt_Item12.IsActive = true;
                        _TblContractItems.Insert(cnt_Item12);
                        if (cnt_Item12.Id > 0)
                        {
                            Tbl_ContractItemDetail _contractItemDetail12 = new Tbl_ContractItemDetail()
                            {
                                DeActiveDate = null,
                                DeActiveCustomer = null,
                                ContractItemPercent = item.CODPercent,
                                ContractItemNumber = null,
                                ContractItemId_fk = cnt_Item12.Id,
                                ContractItemDetailesCost = null,
                                ContractItemDetailesPrice = null,
                                ContractItemDetailesName = null
                            };
                            _TblContractItemDetail.Insert(_contractItemDetail12);
                        }
                    }

                }
                else
                {
                    _error = "ثبت قرار داد انجام نشد، لطفا  اطلاعات وارد شده را بررسی کنید";
                }
                _error = "ثبت با موفقیت انجام شد";

                return cnt.Id;
            }
            catch (Exception ex)
            {
                LogException(ex);
                _error = "خطا در زمان ثبت قرارداد";
                return 0;
            }

        }
        private void DeActiveCurrentContract(int ContractId)
        {
            var _Contract = _TblContract.Table.Where(p => p.Id == ContractId).FirstOrDefault();
            if (_Contract != null)
            {
                _Contract.DeActtivadate = DateTime.Now;
                _Contract.IsActive = false;
                _TblContract.Update(_Contract);

                var _ContractItems = _TblContractItems.Table.Where(p => p.ContractId_fk == _Contract.Id && p.IsActive == true).ToList();
                foreach (var item in _ContractItems)
                {
                    item.IsActive = false;
                    item.DeActiveCustomer = _workContext.CurrentCustomer.Id;
                    item.DeActiveDate = DateTime.Now;
                    _TblContractItems.Update(item);
                    var _ContractItemsDeatils = _TblContractItemDetail.Table.Where(p => p.ContractItemId_fk == item.Id).ToList();
                    foreach (var _item in _ContractItemsDeatils)
                    {
                        _item.DeActiveCustomer = _workContext.CurrentCustomer.Id;
                        _item.DeActiveDate = DateTime.Now;
                        _TblContractItemDetail.Update(_item);
                    }
                }
            }
        }

}
