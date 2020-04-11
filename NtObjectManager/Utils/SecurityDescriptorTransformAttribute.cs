﻿//  Copyright 2020 Google Inc. All Rights Reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

using NtApiDotNet;

namespace NtObjectManager.Utils
{
    class SecurityDescriptorTransformAttribute : BaseTransformAttribute
    {
        public SecurityDescriptorTransformAttribute() 
            : base(typeof(SecurityDescriptor))
        {
        }

        protected override object DefaultValue()
        {
            return new SecurityDescriptor();
        }

        protected override NtResult<object> Parse(string value, bool throw_on_error)
        {
            return SecurityDescriptor.Parse(value, false).Cast<object>();
        }
    }
}
