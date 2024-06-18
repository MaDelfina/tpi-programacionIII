﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interface
{
    public interface IRepositoryReservation : IRepositoryBase<Reservation>
    {
        ICollection<Sneaker> AddToReservation(Sneaker sneaker, int reservationId);
    }
}