﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.ComponentModel.DataAnnotations;

namespace FormatterWebSite
{
    public class Employee
    {
        [Range(10, 100)]
        public int Id { get; set; }

        [MinLength(15)]
        public string Name { get; set; }
    }
}