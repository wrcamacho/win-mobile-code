﻿/*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/
namespace com.google.zxing.oned
{
    /**
     * <p>{@link Reader}s which also implement this interface read one-dimensional barcode
     * formats, and expose additional functionality that is specific to this type of barcode.</p>
     *
     * @author Sean Owen
     */

    using com.google.zxing.common;  

    public interface OneDReader :Reader
    {
       /**
       * <p>Attempts to decode a one-dimensional barcode format given a single row of
       * an image.</p>
       *
       * @param rowNumber row number from top of the row
       * @param row the black/white pixel data of the row
       * @param hints decode hints
       * @return {@link Result} containing encoded string and start/end of barcode
       * @throws ReaderException if an error occurs or barcode cannot be found
       */
      Result decodeRow(int rowNumber, BitArray row, System.Collections.Hashtable hints);
    
    }

}