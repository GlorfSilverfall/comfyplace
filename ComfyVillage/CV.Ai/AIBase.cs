﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CV.Agents;
using CV.Agents.Intents;

namespace CV.Ai
{
    public abstract class AIBase<TAgent> : IIa
    {
        protected AIBase()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public abstract void Compute(IEnumerable<IAgent> sworld);

        protected TAgent _agent;

    }
}