// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

public class Exceptions
{
    public static void ThrowNested()
    {
        try
        {
            ThrowInner();
        }
        catch (Exception e)
        {
            throw new Exception("Outer exception", e);
        }
    }

    private static void ThrowInner() => throw new Exception("Inner exception");

    public static void ThrowDeep() => ThrowPing(5);

    private static void ThrowPing(int count)
    {
        if (count == 0)
        {
            throw new Exception("Deep exception");
        }
        ThrowPong(count - 1);
    }

    private static void ThrowPong(int count)
    {
        if (count == 0)
        {
            throw new Exception("Deep exception");
        }
        ThrowPing(count - 1);
    }

    public static async Task ThrowAsync(HttpContext context)
    {
        await Task.Yield();
        await ThrowingAsyncMethod1();
    }

    private static async Task ThrowingAsyncMethod1()
    {
        await Task.Yield();
        await ThrowingAsyncMethod2();
    }

    private static async Task ThrowingAsyncMethod2()
    {
        await Task.Yield();
        await ThrowingAsyncMethod3();
    }

    private static async Task ThrowingAsyncMethod3()
    {
        await Task.Yield();
        throw new Exception("Async exception");
    }
}
