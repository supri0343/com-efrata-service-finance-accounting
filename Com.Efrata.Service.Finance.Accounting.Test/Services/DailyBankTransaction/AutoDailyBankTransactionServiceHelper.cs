using Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.Services.DailyBankTransaction;
using Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.Services.JournalTransaction;
using Com.Efrata.Service.Finance.Accounting.Lib.BusinessLogic.VBRequestDocument;
using Com.Efrata.Service.Finance.Accounting.Lib.Models.GarmentInvoicePurchasingDisposition;
using Com.Efrata.Service.Finance.Accounting.Lib.Models.OthersExpenditureProofDocument;
using Com.Efrata.Service.Finance.Accounting.Lib.Models.PaymentDispositionNote;
using Com.Efrata.Service.Finance.Accounting.Lib.ViewModels.NewIntegrationViewModel;
using Com.Efrata.Service.Finance.Accounting.Lib.ViewModels.OthersExpenditureProofDocumentViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Com.Efrata.Service.Finance.Accounting.Test.Services.DailyBankTransaction
{
    public class AutoDailyBankTransactionServiceHelper : IAutoDailyBankTransactionService
    {
        public async Task<int> AutoCreateFromClearenceVB(List<int> vbRealizationIds, AccountBankViewModel bank)
        {
            await Task.Delay(1000);
            return await Task.FromResult(1);
        }

        public async Task<int> AutoCreateFromClearenceVB(List<int> vbRealizationIds, AccountBankViewModel bank, string referenceNo)
        {
            await Task.Delay(1000);
            return await Task.FromResult(1);
        }

        public async Task<int> AutoCreateFromGarmentInvoicePurchasingDisposition(GarmentInvoicePurchasingDispositionModel model)
        {
            await Task.Delay(1000);
            return await Task.FromResult(1);
        }

        public async Task<int> AutoCreateFromOthersExpenditureProofDocument(OthersExpenditureProofDocumentModel model, List<OthersExpenditureProofDocumentItemModel> itemModels)
        {
            await Task.Delay(1000);
            return await Task.FromResult(1);
        }

        public async Task<int> AutoCreateFromPaymentDisposition(PaymentDispositionNoteModel model)
        {
            await Task.Delay(1000);
            return await Task.FromResult(1);
        }

        public async Task<int> AutoCreateVbApproval(List<ApprovalVBAutoJournalDto> dtos)
        {
            await Task.Delay(1000);
            return await Task.FromResult(1);
        }

        public async Task<int> AutoRevertFromGarmentInvoicePurchasingDisposition(GarmentInvoicePurchasingDispositionModel model)
        {
            await Task.Delay(1000);
            return await Task.FromResult(1);
        }

        public async Task<int> AutoRevertFromOthersExpenditureProofDocument(OthersExpenditureProofDocumentModel model, List<OthersExpenditureProofDocumentItemModel> itemModels)
        {
            await Task.Delay(1000);
            return await Task.FromResult(1);
        }

        public async Task<int> AutoRevertFromPaymentDisposition(PaymentDispositionNoteModel model)
        {
            await Task.Delay(1000);
            return await Task.FromResult(1);
        }
    }
}
