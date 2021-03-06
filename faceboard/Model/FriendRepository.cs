﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using faceboardpro.Domain;
using faceboardpro.Domain;
using faceboardpro.Helper;

namespace faceboardpro.Model
{
    class FriendRepository:IFriend
    {
        public ICollection<Friend> GetAllAccount(Friend acc)
        {
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                return session.CreateCriteria(typeof(Friend)).List<Friend>();
            }
        }

        public void Insert(Friend acc)
        {
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(acc);

                    transaction.Commit();
                }
            }
        }

        public void Update(Friend acc)
        {
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    //session.Update(acc.Password, acc);
                    transaction.Commit();
                }
            }
        }

        public void Delete(Friend acc)
        {
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    //session.Delete(acc.UserName);
                    transaction.Commit();
                }
            }
        }
    }
}
