﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestfulieClient.resources
{
    public interface IRemoteResourceService
    {
        object Execute(string uri, string transitionName);
        String GetResourceFromXml(string uri);
    }
}
