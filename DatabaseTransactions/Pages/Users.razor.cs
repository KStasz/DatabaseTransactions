using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseTransactions.Interfaces;
using DatabaseTransactions.Models;

namespace DatabaseTransactions.Pages
{
    public partial class Users : ComponentBase
    {
        [Inject] public IPeopleRepository _peopleRepository { get; set; }
        public List<People> peoples { get; set; }
        public People selectedPeople { get; set; } = new People();
        public ModalState actualModalState { get; set; } = ModalState.hide;
        public ActionState actualActionState { get; set; } = ActionState.none;
        public string ModalClass { get; set; } = "modal fade";
        public string ModalStyle { get; set; } = "display: none;";

        protected override async Task OnInitializedAsync()
        {
            peoples = await _peopleRepository.GetPeoples();
            await base.OnInitializedAsync();
        }

        private void AddUser(People item = null)
        {
            if (item != null)
            {
                selectedPeople = item;
                actualActionState = ActionState.Update;
                ShowModal();
            }
            else
            {
                selectedPeople = new People();
                actualActionState = ActionState.Create;
                ShowModal();
            }
        }

        private async Task SaveModalChanges(People item)
        {
            if (actualActionState == ActionState.Create)
            {
                await _peopleRepository.AddPeople(item);
            }
            else if (actualActionState == ActionState.Update)
            {
                await _peopleRepository.UpdatePeople(item);
            }
            else if (actualActionState == ActionState.Delete)
            {
                await _peopleRepository.RemovePeople(item);
            }
            peoples = await _peopleRepository.GetPeoples();
            HideModal();
        }

        private void RemoveUser(People item)
        {
            selectedPeople = item;
            actualActionState = ActionState.Delete;
            ShowModal();
        }


        private void ShowModal()
        {
            actualModalState = ModalState.show;
            ModalClass = "modal fade show";
            ModalStyle = "display: block; padding-right: 16px; background-color: rgba(0,0,0,0.6);";
        }

        private void HideModal()
        {
            actualModalState = ModalState.hide;
            actualActionState = ActionState.none;
            ModalClass = "modal fade";
            ModalStyle = "display: none;";
        }
    }
}
