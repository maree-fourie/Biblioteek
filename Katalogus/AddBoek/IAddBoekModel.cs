﻿using Biblioteek.Services;
using Biblioteek.Types;

namespace Biblioteek.Katalogus
{
    public interface IAddBoekModel
    {
        IDatabaseAccess DatabaseAccess { get; set; }

        ActionResult AddBoek(BoekInformation boekInformation);

        void Initialize();

        BoekNommer NextBoekNommer();
    }
}