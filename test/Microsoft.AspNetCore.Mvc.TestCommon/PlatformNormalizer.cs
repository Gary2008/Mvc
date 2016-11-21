// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Razor;

namespace Microsoft.AspNetCore.Mvc
{
    public static class PlatformNormalizer
    {
        // Assuming windows based source location is passed in,
        // it gets normalized to other platforms.
        public static SourceLocation NormalizedSourceLocation(int absoluteIndex, int lineIndex, int characterIndex)
        {
            var windowsNewLineLength = "\r\n".Length;
            var differenceInLength = windowsNewLineLength - Environment.NewLine.Length;
            return new SourceLocation(absoluteIndex - (differenceInLength * lineIndex), lineIndex, characterIndex);
        }
    }
}