﻿using PetShopLib.Enums;
using PetShopLib.Impl.Model;
using PetShopLib.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopLib.Impl;

public class PetFood : BaseEntity, IPetFood
{
    [Required]
    public AnimalTypeEnum AnimalType { get; set; }
    public Guid ID { get; set; }
    public decimal Price { get; set; }
    public decimal Cost { get; set; }

    public PetFood()
    {
        ID = Guid.NewGuid();
    }

    public PetFood ShallowCopy()
    {
        return (PetFood)MemberwiseClone();
    }
}
