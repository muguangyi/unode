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
    [NodeInterface("InvalidNode")]
    public sealed class InvalidNode : Node
    {
        public override byte[] Export()
        {
            return null;
        }

        public override void Import(byte[] data)
        { }

        public override void Init()
        { }

        public override void Loaded()
        { }
    }
}
