/*
 * Copyright © The DevOps Collective, Inc. All rights reserved.
 * Licensed under GNU GPL v3. See top-level LICENSE.txt for more details.
 */

namespace Sample.TestExt.Thingy
{
    public interface IThingy : TugDSC.Ext.IProviderProduct
    {
        void SetThing(string value);

        string GetThing();
    }
}