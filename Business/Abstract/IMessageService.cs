using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMessageService
    {
        List<Message> GetList();
        List<Message> GetListInbox();
        List<Message> GetListSendbox();
        Message GetById(int id);
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        void UpdateMessage(Message message);

    }
}
