﻿using DreamsIT.Data.BaseTypes;
using DreamsIT.MoySklad.RestClient.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DreamsIT.MoySklad.RestClient.Models
{
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "priceType", IsNullable = false)]
    public class PriceType:IKeyItem<Guid>
    {
        [XmlIgnore]
        public Guid Id { get; set; }

        [XmlAttribute(AttributeName = "index")]
        public int Index { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "updated")]
        public DateTime Updated { get; set; }

        [XmlAttribute(AttributeName = "updatedBy")]
        public string UpdatedBy { get; set; }

        [XmlAttribute(AttributeName = "readMode")]
        public ReadMode ReadMode { get; set; }

        [XmlAttribute(AttributeName = "changeMode")]
        public ChangeMode ChangeMode { get; set; }

        [XmlElement(ElementName = "accountUuid")]
        public Guid AccountUuid { get; set; }

        [XmlElement(ElementName = "accountId")]
        public Guid AccountId { get; set; }

        [XmlElement(ElementName = "uuid")]
        public Guid Uuid { get; set; }
    }

    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRootAttribute(Namespace = "", ElementName = "collection", IsNullable = false)]
    public class PriceTypeCollection
    {
        public PriceTypeCollection()
        {
            PriceTypes = new List<PriceType>();
        }

        [XmlElement(ElementName = "priceType")]
        public List<PriceType> PriceTypes { get; set; }
    }
}
