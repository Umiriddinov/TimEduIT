﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimEduIT.Domain.Exceptions.File;

public class ImageNotFoundException : NotFoundException
{
    public ImageNotFoundException()
    {
        this.TitleMessage = "Image not found!";
    }
}
