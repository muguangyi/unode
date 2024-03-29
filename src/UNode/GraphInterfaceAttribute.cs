﻿/*
 * This file is part of the UNode package.
 *
 * (c) MuGuangyi <muguangyi@hotmail.com>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;

namespace UNode
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class GraphInterfaceAttribute : Attribute
    {
        public GraphInterfaceAttribute(SpotType type)
        {
            this.Type = type;
        }

        public SpotType Type { get; } = SpotType.In;
    }
}