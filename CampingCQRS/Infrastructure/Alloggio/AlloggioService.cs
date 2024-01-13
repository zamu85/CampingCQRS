using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Domain;

namespace Application.Alloggio
{
    public class AlloggioService
    {
        private IUnitOfWork _unitOfwork;

        public AlloggioService(IUnitOfWork unitOfWork)
        {
            _unitOfwork = unitOfWork;
        }
    }
}