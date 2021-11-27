using AutoMapper;
using QuyLe.Core.Domain.Editor;
using QuyLe.SharedMvc.Editor.Models;

namespace QuyLe.SharedMvc.Editor.Infrastructor
{
    public class EditorProfile : Profile
    {
        public EditorProfile()
        {
            #region Draft
            CreateMap<Draft, DraftModel>()
                .ForMember(x => x.ModifiedDate, opt => opt.Ignore())
                .ForMember(x => x.CreatedDate, opt => opt.Ignore());
            CreateMap<DraftModel, Draft>()
                .ForMember(x => x.CreatedDate, opt => opt.Ignore())
                .ForMember(x => x.ModifiedDate, opt => opt.Ignore())
                .ForMember(x => x.FkDraftDetaDraft1920BF5CBackReferences, opt => opt.Ignore())
                .ForMember(x => x.DraftTopicId1A14E395, opt => opt.Ignore());
            #endregion

            #region DraftDetail
            CreateMap<DraftDetail, DraftDetailModel>();
            CreateMap<DraftDetailModel, DraftDetail>()
                .ForMember(x => x.DraftDetaParag1B0907CE, opt => opt.Ignore())
                .ForMember(x => x.DraftDetaDraft1920BF5C, opt => opt.Ignore());
            #endregion

            #region Paragraph
            CreateMap<Paragraph, ParagraphModel>();
            CreateMap<ParagraphModel, Paragraph>()
                .ForMember(x => x.FkDraftDetaParag1B0907CEBackReferences, opt => opt.Ignore())
                .ForMember(x => x.ParagraphCateg1BFD2C07, opt => opt.Ignore());
            #endregion

            #region Topic
            CreateMap<Topic, TopicModel>();
            CreateMap<TopicModel, Topic>()
                .ForMember(x => x.FkDraftTopicId1A14E395BackReferences, opt => opt.Ignore());                
            #endregion
        }
    }
}
