﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimEduIT.Domain.Exceptions.Users;

public class UserCacheDataExpiredException : ExpiredException
{
    public UserCacheDataExpiredException()
    {
        TitleMessage = "User data has expired!";
    }

}
