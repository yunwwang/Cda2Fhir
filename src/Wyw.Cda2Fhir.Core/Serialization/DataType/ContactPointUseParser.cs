﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using Hl7.Fhir.Model;

namespace Wyw.Cda2Fhir.Core.Serialization.DataType
{
    public class ContactPointUseParser
    {
        public ContactPoint.ContactPointUse? FromXml(XAttribute attribute)
        {
            if (string.IsNullOrEmpty(attribute?.Value))
                return null;

            switch (attribute.Value)
            {
                case "H":
                case "HP":
                case "HV":
                    return ContactPoint.ContactPointUse.Home;

                case "WP":
                    return ContactPoint.ContactPointUse.Work;

                case "TMP":
                    return ContactPoint.ContactPointUse.Temp;

                case "OLD":
                    return ContactPoint.ContactPointUse.Old;

                case "MC":
                    return ContactPoint.ContactPointUse.Mobile;

                default:
                    return null;
            }
        }

    }
}