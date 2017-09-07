﻿using System;
using System.Collections.Generic;
using System.ServiceModel;
using TakeMyNote.Model;

namespace TakeMyNote.WcfServices
{
    [ServiceContract]
    public interface INoteService
    {
        [OperationContract]
        Note GetById(int id);

        [OperationContract]
        Note GetByLink(string sharedId);

        [OperationContract]
        IEnumerable<NoteDigest> GetAllByUserId(int userId);

        [OperationContract]
        void Create(Note note);

        [OperationContract]
        void Update(Note note);

        [OperationContract]
        void Delete(int id);
    }
}       
