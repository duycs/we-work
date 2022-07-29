﻿using AppShareDomain.DTOs.Job;
using JobDomain.AgreegateModels.JobAgreegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication.Services
{
    public interface IJobService
    {
        public Task<List<StepDto>> GenerateStepFromProduct(int productId);
    }
}
