﻿using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.DataAccess.Abstracts;
using DreamsIT.MoySklad.RestClient.Models;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace DreamsIT.MoySklad.DataFakes.Implementation
{
    public class FakeRepositoriesFactory : IMsContextFactory
    {
        private Cache _cache;

        public FakeRepositoriesFactory(HttpContext context)
        {
            _cache = context.Cache;
        }

        private object constructRepo(string name, Func<object> method)
        {
            var repo = _cache[name];
            if (repo == null)
            {
                repo = method();
                _cache.Insert(name, repo, null, Cache.NoAbsoluteExpiration, new TimeSpan(1, 1, 1, 1));
            }
            return repo;
        }

        private List<Price> _prices = new List<Price>();

        public IRepository<Price, Guid> Prices
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Demand, Guid> Demands
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.CashOut, Guid> CashOuts
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Company, Guid> Companies
        {
            get { throw new NotImplementedException(); }
        }


        private List<GoodFolder> _goodFolders = new List<GoodFolder>()
        {
            new GoodFolder()
            {
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Archived=false, 
                ChangeMode=ChangeMode.SELF, 
                Externalcode="eyKCqoDfgAyZqrAulGSlh0", 
                Id=Guid.Parse("07bef3ae-8cee-11e4-90a2-8ecb000a1289"), 
                Name="SelfX", 
                ProductCode="", 
                ReadMode=ReadMode.ALL, 
                Updated="2014-12-26T13:57:48.802+03:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Uuid=Guid.Parse("07bef3ae-8cee-11e4-90a2-8ecb000a1289")
            },
            new GoodFolder()
            {
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Archived=false, 
                ChangeMode=ChangeMode.SELF, 
                Externalcode="xrgHawfZihiJNxpBidSAE0", 
                Id=Guid.Parse("0c8d01cb-3ff4-11e4-90a2-8eca000b8b09"), 
                Name="Дополнительные расходные материалы", 
                ProductCode="", 
                ReadMode=ReadMode.ALL, 
                Updated="2014-09-19T15:56:54.310+04:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Uuid=Guid.Parse("0c8d01cb-3ff4-11e4-90a2-8eca000b8b09")
            },
            new GoodFolder()
            {
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Archived=false, 
                ChangeMode=ChangeMode.SELF, 
                Externalcode="jtDm2qMHi8yFYKMsHXeus3", 
                Id=Guid.Parse("0cc6d4ed-3ff4-11e4-90a2-8eca000b8bf6"), 
                Name="Кальяны в сборе", 
                ProductCode="", 
                ReadMode=ReadMode.ALL, 
                Updated="2014-09-19T15:56:54.689+04:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Uuid=Guid.Parse("0cc6d4ed-3ff4-11e4-90a2-8eca000b8bf6")
            }
        };

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.GoodFolder, Guid> GoodFolders
        {
            get { return constructRepo("GoodFolders", () => new BaseFakeRepository<GoodFolder, Guid>(_goodFolders)) as IRepository<GoodFolder, Guid>; }
        }

        private List<Good> _goods = new List<Good>()
        {
            new Good()
            {
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"),
                Archived=false, 
                BuyPrice=0.0, 
                ChangeMode=ChangeMode.SELF, 
                Code="", 
                Description="", 
                Externalcode="tr_xoxxegViPnBGHWvzOu0", 
                Id=Guid.Parse("003a1f1a-43db-11e4-90a2-8eca00258a8f"), 
                Uuid=Guid.Parse("003a1f1a-43db-11e4-90a2-8eca00258a8f"), 
                Images=null, 
                IsSerialTrackable=false, 
                MinPrice=120250.0,
                Name="Tangiers Birquq 250 гр. Sour Grape", 
                ParentUuid=Guid.Parse("e94b9ac0-43d9-11e4-90a2-8eca00254323"), 
                Preferences=null, 
                ProductCode="", 
                ReadMode=ReadMode.ALL, 
                SalePrice=185000.0, 
                UomUuid=Guid.Parse("19f1edc0-fc42-4001-94cb-c9ec9c62ec10"), 
                Updated="2014-09-24T15:07:40.866+04:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Volume=0.0, 
                Weight=0.0, 
                SalePrices=new List<Price>()
                {
                    new Price()
                    {
                        AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        ChangeMode=ChangeMode.All, 
                        ReadMode=ReadMode.ALL, 
                        Id=Guid.Parse("003a25b9-43db-11e4-90a2-8eca00258a94"), 
                        PriceTypeUuid=Guid.Parse("5ab3ad2c-13fd-11e4-4810-002590a28eca"), 
                        Uuid=Guid.Parse("003a25b9-43db-11e4-90a2-8eca00258a94"), 
                        Value=138750.0
                    },
                    new Price()
                    {
                        AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        ChangeMode=ChangeMode.All, 
                        ReadMode=ReadMode.ALL, 
                        Id=Guid.Parse("003a2560-43db-11e4-90a2-8eca00258a92"), 
                        PriceTypeUuid=Guid.Parse("5ab3adfa-13fd-11e4-adb1-002590a28eca"), 
                        Uuid=Guid.Parse("003a2560-43db-11e4-90a2-8eca00258a92"), 
                        Value=120250.0
                    },
                    new Price()
                    {
                        AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        ChangeMode=ChangeMode.All, 
                        ReadMode=ReadMode.ALL, 
                        Id=Guid.Parse("003a24a0-43db-11e4-90a2-8eca00258a91"), 
                        PriceTypeUuid=Guid.Parse("5ab3aba2-13fd-11e4-7dd7-002590a28eca"), 
                        Uuid=Guid.Parse("003a24a0-43db-11e4-90a2-8eca00258a91"), 
                        Value=166200.0
                    },
                    new Price()
                    {
                        AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        ChangeMode=ChangeMode.All, 
                        ReadMode=ReadMode.ALL, 
                        Id=Guid.Parse("003a260c-43db-11e4-90a2-8eca00258a95"), 
                        PriceTypeUuid=Guid.Parse("5d441fe3-a9b0-4a52-b1f0-6d256f1d8a7e"), 
                        Uuid=Guid.Parse("003a260c-43db-11e4-90a2-8eca00258a95"), 
                        Value=185000.0
                    }
                }
            },
            new Good()
            {
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"),
                Archived=false, 
                BuyPrice=0.0, 
                ChangeMode=ChangeMode.SELF, 
                Code="", 
                Description="", 
                Externalcode="RWuW7hqSgSmDWecjiZvLK0", 
                Id=Guid.Parse("00d157bf-77da-11e4-90a2-8eca00379a51"), 
                Uuid=Guid.Parse("00d157bf-77da-11e4-90a2-8eca00379a51"), 
                Images=null, 
                IsSerialTrackable=false, 
                MinPrice=19000.0,
                Name="Табак Afzal 40 гр. Черника", 
                ParentUuid=Guid.Parse("4142de4f-6024-11e4-90a2-8ecb005b0fa4"), 
                Preferences=null, 
                ProductCode="", 
                ReadMode=ReadMode.ALL, 
                SalePrice=29000.0, 
                UomUuid=Guid.Parse("19f1edc0-fc42-4001-94cb-c9ec9c62ec10"), 
                Updated="2014-11-29T18:13:44.884+03:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Volume=0.0, 
                Weight=0.0, 
                SalePrices=new List<Price>()
                {
                    new Price()
                    {
                        AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        ChangeMode=ChangeMode.All, 
                        ReadMode=ReadMode.ALL, 
                        Id=Guid.Parse("00d15ca8-77da-11e4-90a2-8eca00379a53"), 
                        PriceTypeUuid=Guid.Parse("5d441fe3-a9b0-4a52-b1f0-6d256f1d8a7e"), 
                        Uuid=Guid.Parse("00d15ca8-77da-11e4-90a2-8eca00379a53"), 
                        Value=29000.0
                    },
                    new Price()
                    {
                        AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        ChangeMode=ChangeMode.All, 
                        ReadMode=ReadMode.ALL, 
                        Id=Guid.Parse("00d15d53-77da-11e4-90a2-8eca00379a54"), 
                        PriceTypeUuid=Guid.Parse("5ab3aba2-13fd-11e4-7dd7-002590a28eca"), 
                        Uuid=Guid.Parse("00d15d53-77da-11e4-90a2-8eca00379a54"), 
                        Value=26100.0
                    },
                    new Price()
                    {
                        AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"),
                        AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"),
                        ChangeMode=ChangeMode.All,
                        ReadMode=ReadMode.ALL,
                        Id=Guid.Parse("00d15d9f-77da-11e4-90a2-8eca00379a55"), 
                        PriceTypeUuid=Guid.Parse("5ab3ad2c-13fd-11e4-4810-002590a28eca"), 
                        Uuid=Guid.Parse("00d15d9f-77da-11e4-90a2-8eca00379a55"), 
                        Value=20300.0
                    },
                    new Price()
                    {
                        AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        ChangeMode=ChangeMode.All, 
                        ReadMode=ReadMode.ALL, 
                        Id=Guid.Parse("00d15de8-77da-11e4-90a2-8eca00379a56"), 
                        PriceTypeUuid=Guid.Parse("5ab3adfa-13fd-11e4-adb1-002590a28eca"), 
                        Uuid=Guid.Parse("00d15de8-77da-11e4-90a2-8eca00379a56"), 
                        Value=19000.0
                    }
                }
            },
            new Good()
            {
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"),
                Archived=false, 
                BuyPrice=0.0, 
                ChangeMode=ChangeMode.SELF, 
                Code="", 
                Description="", 
                Externalcode="HWQZg6LMhcq7qTOsP4z5c3", 
                Id=Guid.Parse("015065e3-77dc-11e4-90a2-8eca0037bbc8"), 
                Uuid=Guid.Parse("015065e3-77dc-11e4-90a2-8eca0037bbc8"), 
                Images=null, 
                IsSerialTrackable=false, 
                MinPrice=13000.0,
                Name="Безникотиновая смесь для кальяна Соекс Черешня 50 г", 
                ParentUuid=Guid.Parse("8393d2c0-77da-11e4-90a2-8eca0037a354"), 
                Preferences=null, 
                ProductCode="", 
                ReadMode=ReadMode.ALL, 
                SalePrice=20000.0, 
                UomUuid=Guid.Parse("19f1edc0-fc42-4001-94cb-c9ec9c62ec10"), 
                Updated="2014-11-29T18:25:48.377+03:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Volume=0.0, 
                Weight=0.0, 
                SalePrices=new List<Price>()
                {
                    new Price()
                    {
                        AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        ChangeMode=ChangeMode.All, 
                        ReadMode=ReadMode.ALL, 
                        Id=Guid.Parse("01506bab-77dc-11e4-90a2-8eca0037bbcb"), 
                        PriceTypeUuid=Guid.Parse("5ab3ad2c-13fd-11e4-4810-002590a28eca"), 
                        Uuid=Guid.Parse("01506bab-77dc-11e4-90a2-8eca0037bbcb"), 
                        Value=15000.0
                    },
                    new Price()
                    {
                        AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        ChangeMode=ChangeMode.All, 
                        ReadMode=ReadMode.ALL, 
                        Id=Guid.Parse("01506c3d-77dc-11e4-90a2-8eca0037bbcd"), 
                        PriceTypeUuid=Guid.Parse("5ab3adfa-13fd-11e4-adb1-002590a28eca"), 
                        Uuid=Guid.Parse("01506c3d-77dc-11e4-90a2-8eca0037bbcd"), 
                        Value=13000.0
                    },
                    new Price()
                    {
                        AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"),
                        AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"),
                        ChangeMode=ChangeMode.All,
                        ReadMode=ReadMode.ALL,
                        Id=Guid.Parse("01506bf7-77dc-11e4-90a2-8eca0037bbcc"), 
                        PriceTypeUuid=Guid.Parse("5ab3aba2-13fd-11e4-7dd7-002590a28eca"), 
                        Uuid=Guid.Parse("01506bf7-77dc-11e4-90a2-8eca0037bbcc"), 
                        Value=18000.0
                    },
                    new Price()
                    {
                        AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                        ChangeMode=ChangeMode.All, 
                        ReadMode=ReadMode.ALL, 
                        Id=Guid.Parse("00d15de8-77da-11e4-90a2-8eca00379a56"), 
                        PriceTypeUuid=Guid.Parse("5ab3adfa-13fd-11e4-adb1-002590a28eca"), 
                        Uuid=Guid.Parse("00d15de8-77da-11e4-90a2-8eca00379a56"), 
                        Value=19000.0
                    }
                }
            }
        };
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Good, Guid> Goods
        {
            get { return constructRepo("Goods", () => new BaseFakeRepository<Good, Guid>(_goods)) as IRepository<Good, Guid>; }
        }


        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.CustomerOrder, Guid> CustomerOrders
        {
            get { throw new NotImplementedException(); }
        }


        private List<Employee> _employeeses = new List<Employee>(){
            new Employee(){
                Id=Guid.Parse("0c7f4b7e-456d-11e4-90a2-8eca0022bfab"), 
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Archived=false, 
                ChangeMode=ChangeMode.All, 
                Description="", 
                Email="061412@gmail.com", 
                ExternalCode="hsSOfC1diM62IbD4UUjn13", 
                FirstName="Станислав", 
                LastName="Медков", 
                MiddleName="Сергеевич", 
                Name="Медков С. С.", 
                Phone="8-911-702-23-91", 
                ReadMode=ReadMode.ALL, 
                Uid="stas@ооо нарджилия",
                Updated="2014-09-26T15:05:39.138+04:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Uuid=Guid.Parse("0c7f4b7e-456d-11e4-90a2-8eca0022bfab")
            },
            new Employee(){
                Id=Guid.Parse("1f5ac880-7f94-11e4-90a2-8ecb00259772"), 
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Archived=false,
                ChangeMode=ChangeMode.All, 
                Description="", 
                Email="", 
                ExternalCode="NVugPUPQi-qrSODD75afj1", 
                FirstName="Вадим и Артем", 
                LastName="The LOFT СПБ", 
                MiddleName="", 
                Name="The LOFT СПБ В.", 
                Phone="", 
                ReadMode=ReadMode.ALL, 
                Uid="loft-spb@ооо нарджилия",
                Updated="2014-12-09T14:11:26.405+03:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Uuid=Guid.Parse("1f5ac880-7f94-11e4-90a2-8ecb00259772")
            },
            new Employee(){
                Id=Guid.Parse("be01fb87-1326-11e4-c801-002590a28eca"), 
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Archived=false, 
                ChangeMode=ChangeMode.All, 
                Description="Кладовщик-продавец", 
                Email="", 
                ExternalCode="BcxvDPR0iqiGFBKftqKqF0", 
                FirstName="Кирилл", 
                LastName="Федорищев", 
                MiddleName="Максимович", 
                Name="Федорищев К. М.", 
                Phone="8-981-839-34-88", 
                ReadMode=ReadMode.ALL, 
                Uid="klad.prod.@ооо нарджилия",
                Updated="2014-09-19T15:39:15.628+04:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Uuid=Guid.Parse("be01fb87-1326-11e4-c801-002590a28eca")
            }
        };

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Employee, Guid> Employees
        {
            get { return constructRepo("Employees", () => new BaseFakeRepository<Employee, Guid>(_employeeses)) as IRepository<Employee, Guid>; }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Enter, Guid> Enters
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.EnterPosition, Guid> EnterPositions
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.GoodRef, Guid> GoodRefs
        {
            get { throw new NotImplementedException(); }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Loss, Guid> Losses
        {
            get { throw new NotImplementedException(); }
        }

        private List<MyCompany> _myCompanies = new List<MyCompany>()
        {
            new MyCompany()
            {
                Id=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"),
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Archived=false, 
                AutoDiscount=0.0, 
                ChangeMode=RestClient.Models.Enums.ChangeMode.SELF, 
                ReadMode=RestClient.Models.Enums.ReadMode.ALL, 
                ChiefAccountant="Медков С.С.", 
                Code="1", 
                CompanyType=RestClient.Models.Enums.CompanyType.URLI,
                Contact=new Contact(){Address="", Email="061412@gmail.com", Faxes="", Mobiles="", Phones=""}, 
                Created="2010-09-27T02:30:22.529+04:00", 
                Description="", 
                Director="Медков С.С.", 
                Discount=0.0, 
                DiscountCorrection=0.0, 
                ExternalCode="1", 
                Name="ооо нарджилия", 
                Requisite=new Requisite(){ActualAddress="190031, Спасский пер. д.11\\1", Inn="7838432080", Kpp="783801001", LegalAddress="190031, Спасский пер. д.11\\1", LegalTitle="Общество с ограниченной ответственностью \"Нарджилия\"", Okpo="62993750"},
                Tags=null, 
                Updated="2010-09-27T02:30:22.529+04:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Uuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"),
                BankAccount=new BankAccount(){AccountNumber="", BankLocation="", BankName="", Bic="", ChangeMode=RestClient.Models.Enums.ChangeMode.All, CorrectspondentAccount="", IsDefault=true, ReadMode=RestClient.Models.Enums.ReadMode.ALL, Updated="2014-05-28T00:19:29.207+04:00", UpdatedBy="admin@ооо нарджилия"}
            }
        };
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.MyCompany, Guid> MyCompanies
        {
            get { return constructRepo("MyCompanies", () => new BaseFakeRepository<MyCompany, Guid>(_myCompanies)) as IRepository<MyCompany, Guid>; }
        }

        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.PurchaseOrderPosition, Guid> PurchaseOrderPositions
        {
            get { throw new NotImplementedException(); }
        }

        private List<PaymentIn> _paymentIns = new List<PaymentIn>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.PaymentIn, Guid> PaymentIns
        {
            get { return constructRepo("PaymentIns", () => new BaseFakeRepository<PaymentIn, Guid>(_paymentIns)) as IRepository<PaymentIn, Guid>; }
        }

        private List<PaymentOut> _paymentOuts = new List<PaymentOut>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.PaymentOut, Guid> PaymentOuts
        {
            get { return constructRepo("PaymentOuts", () => new BaseFakeRepository<PaymentOut, Guid>(_paymentOuts)) as IRepository<PaymentOut, Guid>; }
        }

        private List<PurchaseOrder> _purshseOrders = new List<PurchaseOrder>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.PurchaseOrder, Guid> PurchaseOrders
        {
            get { return constructRepo("PurchaseOrders", () => new BaseFakeRepository<PurchaseOrder, Guid>(_purshseOrders)) as IRepository<PurchaseOrder, Guid>; }
        }
        
        private List<RetailDemand> _retailDemands = new List<RetailDemand>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.RetailDemand, Guid> RetailDemands
        {
            get { return constructRepo("RetailDemands", () => new BaseFakeRepository<RetailDemand, Guid>(_retailDemands)) as IRepository<RetailDemand, Guid>; }
        }

        private List<RetailStore> _retailStore = new List<RetailStore>(){
            new RetailStore()
            {
                Id=Guid.Parse("4870a47a-7f94-11e4-90a2-8ecb0025a5ab"),
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Active=true, 
                Address="", 
                ChangeMode=RestClient.Models.Enums.ChangeMode.SELF, 
                Description="", 
                Externalcode="ETcWX1ASilKcdq-WNhvyj2", 
                MyCompanyUuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"), 
                Name="The LOFT СПБ", 
                PriceTypeUuid=Guid.Parse("5d441fe3-a9b0-4a52-b1f0-6d256f1d8a7e"), 
                ReadMode=RestClient.Models.Enums.ReadMode.SELF, 
                Updated="2014-12-09T14:12:35.335+03:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Uuid=Guid.Parse("4870a47a-7f94-11e4-90a2-8ecb0025a5ab"), 
                WarehouseUuid=Guid.Parse("570c7c96-7f91-11e4-90a2-8ecb0024f582")
            },
            new RetailStore()
            {
                Id=Guid.Parse("afb8aace-1328-11e4-03e3-002590a28eca"),
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Active=true, 
                Address="Спб, Рубинштейна, д. 30, лит. А", 
                ChangeMode=RestClient.Models.Enums.ChangeMode.NONE, 
                Description="", 
                Externalcode="QMMJBUAChlKbgVXCeomn-0", 
                MyCompanyUuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"), 
                Name="THE OFFICE", 
                PriceTypeUuid=Guid.Parse("5d441fe3-a9b0-4a52-b1f0-6d256f1d8a7e"), 
                ReadMode=RestClient.Models.Enums.ReadMode.NONE,
                Updated="2014-07-24T15:50:19.569+04:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Uuid=Guid.Parse("afb8aace-1328-11e4-03e3-002590a28eca"), 
                WarehouseUuid=Guid.Parse("8036ce31-baed-48ff-b365-fcb86ad87fd8")
            },
            new RetailStore()
            {
                Id=Guid.Parse("d755aa8f-43c5-11e4-90a2-8eca002101ad"),
                AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                Active=true, 
                Address="", 
                ChangeMode=RestClient.Models.Enums.ChangeMode.SELF, 
                Description="", 
                Externalcode="U3RZu-q8ibiVUoWIa2ycr0", 
                MyCompanyUuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"), 
                Name="ОПТ", 
                PriceTypeUuid=Guid.Parse("5ab3adfa-13fd-11e4-adb1-002590a28eca"), 
                ReadMode=RestClient.Models.Enums.ReadMode.SELF,
                Updated="2014-09-24T12:36:12.829+04:00", 
                UpdatedBy="admin@ооо нарджилия", 
                Uuid=Guid.Parse("d755aa8f-43c5-11e4-90a2-8eca002101ad"), 
                WarehouseUuid=Guid.Parse("8036ce31-baed-48ff-b365-fcb86ad87fd8")
            }
        };
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.RetailStore, Guid> RetailStores
        {
            get { return constructRepo("RetailStores", () => new BaseFakeRepository<RetailStore, Guid>(_retailStore)) as IRepository<RetailStore, Guid>; }
        }

        private List<StockTO> _stockTOs = new List<StockTO>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.StockTO, Guid> StockTOs
        {
            get { return constructRepo("StockTOs", () => new BaseFakeRepository<StockTO, Guid>(_stockTOs)) as IRepository<StockTO, Guid>; }
        }

        private List<CustomerOrderPosition> _customerOrderPositions = new List<CustomerOrderPosition>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.CustomerOrderPosition, Guid> CustomerOrderPositions
        {
            get { return constructRepo("CustomerOrderPositions", () => new BaseFakeRepository<CustomerOrderPosition, Guid>(_customerOrderPositions)) as IRepository<CustomerOrderPosition, Guid>; }
        }

        private List<Supply> _supplies = new List<Supply>();
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Supply, Guid> Supplies
        {
            get { return constructRepo("Supplies", () => new BaseFakeRepository<Supply, Guid>(_supplies)) as IRepository<Supply, Guid>; }
        }

        private List<Warehouse> _warehouses = new List<Warehouse>()
            {
                new Warehouse()
                {
                    Id=Guid.Parse("570c7c96-7f91-11e4-90a2-8ecb0024f582"),
                    AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AgentUuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"), 
                    Archived=false, 
                    ChangeMode=ChangeMode.SELF, 
                    Code="", 
                    Contact=new Contact(){ Phones="", Mobiles="", Faxes="", Email="", Address=""}, 
                    Description="", 
                    ExternalCode="1QcYvIrkh76BiB2rIXYhk3", 
                    Name="The LOFT СПБ", 
                    ReadMode=ReadMode.SELF, 
                    Slots=null, 
                    Updated="2014-12-09T13:51:31.354+03:00", 
                    UpdatedBy="admin@ооо нарджилия", 
                    Uuid=Guid.Parse("570c7c96-7f91-11e4-90a2-8ecb0024f582"), 
                    ParentUuid=null
                },
                new Warehouse()
                {
                    Id=Guid.Parse("79e2fd2c-4314-11e4-90a2-8eca000d33f3"),
                    AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AgentUuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"), 
                    Archived=false, 
                    ChangeMode=ChangeMode.SELF, 
                    Code="", 
                    Contact=new Contact(){ Phones="", Mobiles="", Faxes="", Email="", Address=""}, 
                    Description="", 
                    ExternalCode="eiIedzCSjlmhhwOnHvcJz3", 
                    Name="Владивосток Кацура", 
                    ReadMode=ReadMode.SELF, 
                    Slots=null, 
                    Updated="2014-09-23T15:26:35.128+04:00", 
                    UpdatedBy="admin@ооо нарджилия", 
                    Uuid=Guid.Parse("79e2fd2c-4314-11e4-90a2-8eca000d33f3"), 
                    ParentUuid=Guid.Parse("8036ce31-baed-48ff-b365-fcb86ad87fd8")
                },
                new Warehouse()
                {
                    Id=Guid.Parse("8036ce31-baed-48ff-b365-fcb86ad87fd8"),
                    AccountId=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AccountUuid=Guid.Parse("473d51a0-0e7b-11e2-d8b1-3c4a92f3a0a7"), 
                    AgentUuid=Guid.Parse("335df8f8-45c0-4b15-bd11-24aab2e61ded"), 
                    Archived=false, 
                    ChangeMode=ChangeMode.SELF, 
                    Code="1", 
                    Contact=new Contact(){ Phones="", Mobiles="", Faxes="", Email="", Address="Спб, Рубинштейна 30, лит. А"}, 
                    Description="Склад", 
                    ExternalCode="1", 
                    Name="The Office", 
                    ReadMode=ReadMode.SELF, 
                    Slots=null, 
                    Updated="2014-07-24T15:37:58.270+04:00", 
                    UpdatedBy="admin@ооо нарджилия", 
                    Uuid=Guid.Parse("8036ce31-baed-48ff-b365-fcb86ad87fd8"), 
                    ParentUuid=null
                }
            };
        public Data.BaseTypes.IRepository<DreamsIT.MoySklad.RestClient.Models.Warehouse, Guid> Warehouses
        {
            get { return constructRepo("Warehouses", () => new BaseFakeRepository<Warehouse, Guid>(_warehouses)) as IRepository<Warehouse, Guid>; }
        }

        public IRepository<ShipmentIn, Guid> ShipmentIns
        {
            get { throw new NotImplementedException(); }
        }
    }
}