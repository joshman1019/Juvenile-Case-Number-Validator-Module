namespace JCNV;
public static class JuvenileCaseNumberValidator
{
    public static bool ConfirmValidJuvenileCaseNumber(this string caseNumber, CaseTypes caseType)
    {
        if (caseNumber.Length < 7)
            return false;
        if (caseNumber.Length > 12)
            return false;
        if (caseNumber[0] < 0x30 || caseNumber[0] > 0x40)
            return false;
        if (caseNumber[1] < 0x30 || caseNumber[1] > 0x40)
            return false;
        if (caseNumber[2] != 0x20)
            return false;
        if (caseNumber[3] != 0x4A)
            return false;
        if (caseNumber[5] != 0x20)
            return false;
        if (caseNumber[6] < 0x30 || caseNumber[6] > 0x40)
            return false;
        if (caseNumber.Length > 7)
        {
            if (caseNumber[7] < 0x30 || caseNumber[6] > 0x40)
                return false;
        }
        if (caseNumber.Length > 8)
        {
            if (caseNumber[8] < 0x30 || caseNumber[6] > 0x40)
                return false;
        }
        if (caseNumber.Length > 9)
        {
            if (caseNumber[9] < 0x30 || caseNumber[6] > 0x40)
                return false;
        }
        if (caseNumber.Length > 10)
        {
            if (caseNumber[10] < 0x30 || caseNumber[6] > 0x40)
                return false;
        }
        if (caseNumber.Length > 11)
        {
            if (caseNumber[11] < 0x30 || caseNumber[6] > 0x40)
                return false;
        }

        switch (caseNumber[4])
        {
            case 'A':
                return caseType == CaseTypes.AbuseNeglectDependency ? true : false;
            case 'B':
                return caseType == CaseTypes.Delinquent ? true : false;
            case 'T':
                return caseType == CaseTypes.TerminationOfParentalRights ? true : false;
            case 'E':
                return caseType == CaseTypes.Emancipation ? true : false;
            case 'R':
                return caseType == CaseTypes.ResponsibleIndividualsList ? true : false;
            case 'W':
                return caseType == CaseTypes.JudicialWaiver ? true : false;
            default:
                return false;
        }
    }
}