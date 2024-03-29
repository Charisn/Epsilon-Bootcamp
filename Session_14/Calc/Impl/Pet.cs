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

public class Pet : BaseEntity, IPet
{
    [Required]
    public string Breed { get; set; }
    public PetStatusEnum PetStatus { get; set; }
    public AnimalTypeEnum AnimalType { get; set; }
    public Guid ID { get; set; }
    public decimal Price { get; set; }
    public decimal Cost { get; set; }

    public Pet()
    {
        
            ID = Guid.NewGuid();
        
    }
}
