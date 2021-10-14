using Discount.Grpc.Protos;
using Google.Protobuf.WellKnownTypes;
using System.Threading.Tasks;

namespace Basket.API.GrpcServices
{
    public class DiscountGrpcsService
    {

        private readonly DiscountProtoService.DiscountProtoServiceClient _discountProtoService;

        public DiscountGrpcsService(DiscountProtoService.DiscountProtoServiceClient discountProtoService)
        {
            _discountProtoService = discountProtoService;
        }

        public async Task<CouponModel> GetDiscount(string productName)
        {
            FieldMask fieldMask = new FieldMask();
            fieldMask.Paths.AddRange(new string[] { "id", "amount" });

            var discountRequest = new GetDiscountRequest();
            discountRequest.ProductName = productName;
            discountRequest.FieldMask = fieldMask;

            return await _discountProtoService.GetDiscountAsync(discountRequest);
        }
    }
}
