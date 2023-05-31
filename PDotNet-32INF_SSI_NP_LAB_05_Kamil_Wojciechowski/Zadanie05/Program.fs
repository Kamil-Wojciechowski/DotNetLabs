type TaskProcessor() =
    let mailbox =
        MailboxProcessor.Start(fun inbox ->
            let rec loop() =
                async {
                    let! task = inbox.Receive()
                    printfn "Przetwarzanie zadania: %s" task
                    do! loop()
                }
            loop()
        )

    member this.EnqueueTask(task: string) =
        mailbox.Post(task)

[<EntryPoint>]
let main argv =
    let taskProcessor = TaskProcessor()

    taskProcessor.EnqueueTask("Zadanie 1")
    taskProcessor.EnqueueTask("Zadanie 2")
    taskProcessor.EnqueueTask("Zadanie 3")

    System.Console.ReadLine() |> ignore
    0
