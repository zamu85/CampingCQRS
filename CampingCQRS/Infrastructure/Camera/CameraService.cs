using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Domain;

namespace Application.Camera
{
    public class CameraService
    {
        private IUnitOfWork _unitOfWork;
        public CameraService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}