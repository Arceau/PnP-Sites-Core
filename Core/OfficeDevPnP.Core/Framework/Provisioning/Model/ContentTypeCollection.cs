﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDevPnP.Core.Framework.Provisioning.Model
{
    /// <summary>
    /// Collection of ContentType objects
    /// </summary>
    public partial class ContentTypeCollection : ProvisioningTemplateCollection<ContentType>
    {
        public ContentTypeCollection(ProvisioningTemplate parentTemplate) : base(parentTemplate)
        {

        }
    }
}
