/*
 * This file is part of the UNode package.
 *
 * (c) MuGuangyi <muguangyi@hotmail.com>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

namespace UNode
{
    public delegate byte[] Load(string target);

    public static class NodeLoader
    {
        public static Load Load { get; set; }
    }
}