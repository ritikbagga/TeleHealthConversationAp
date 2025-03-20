using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TeleHealthConversationApp.Models;

namespace TeleHealthConversationApp.ViewModels
{
    public partial class ConversationViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<MessageModel> messages;

        [ObservableProperty]
        private string newMessageText;

        public ConversationViewModel()
        {
            // Sample conversation
            Messages = new ObservableCollection<MessageModel>
            {
                new MessageModel
                {
                    Speaker = "Dr. Smith, PhD",
                    Language = "French",
                    MessageText = "Quand avez-vous remarqué pour la première fois qu’il y avait un problème ?",
                    IsDoctor = true,
                    TimeStamp = DateTime.Now.AddMinutes(-10)
                },
                new MessageModel
                {
                    Speaker = "Person 2",
                    MessageText = "Probablement il y a environ trois semaines. J'ai tendance à avoir un seuil de douleur élevé...",
                    IsDoctor = false,
                    TimeStamp = DateTime.Now.AddMinutes(-9)
                },
                new MessageModel
                {
                    Speaker = "Dr. Smith, PhD",
                    Language = "",
                    MessageText = "I'm glad you came in. We’ll do a blood draw after this meeting. Have you eaten anything yet?",
                    IsDoctor = true,
                    TimeStamp = DateTime.Now.AddMinutes(-8)
                },
                new MessageModel
                {
                    Speaker = "Person 2",
                    MessageText = "No, je n'avais pas rien...",
                    IsDoctor = false,
                    TimeStamp = DateTime.Now.AddMinutes(-7)
                }
            };
        }

        [RelayCommand]
        private void SendMessage()
        {
            if (string.IsNullOrWhiteSpace(NewMessageText))
                return;

            Messages.Add(new MessageModel
            {
                Speaker = "Person 2",
                Language = "",
                MessageText = NewMessageText,
                IsDoctor = false,
                TimeStamp = DateTime.Now
            });

            NewMessageText = string.Empty;
        }
    }

}
