﻿using Application.Models;
using Application.Models.Requests;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IReservationServices
    {
        void Create(int idUser);
        void Delete(int id);
        List<ReservationDto> GetAll();
        ReservationDto GetById(int id);
        void FinalizedReservation(int id);
        List<SneakerDto>? AddToReservation(ReservationSneakerRequest rsDto);
        void BuyReservation(int idReservation);
    }
}