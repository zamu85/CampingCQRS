using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Domain;

namespace Application.Elettricita
{
    public class ElettricitaService
    {
        private IUnitOfWork _unitOfWork;

        public ElettricitaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}